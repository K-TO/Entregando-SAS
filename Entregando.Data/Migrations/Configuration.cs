namespace Entregando.Data.Migrations
{
    using Entregando.Data.Context;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.IO;
    using System.Linq;
    using System.Text;

    public sealed class Configuration : DbMigrationsConfiguration<EntregandoContext>
    {
        private readonly string[] _customCommands;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            _customCommands = SeedDataBase();
        }

        protected override void Seed(EntregandoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            try
            {
                SeedIdentity(context);
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat("Se generaron los siguientes errores: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        public void SeedIdentity(EntregandoContext entities)
        {
            if (_customCommands != null && _customCommands.Length > 0)
            {
                foreach (var command in _customCommands)
                {
                    entities.Database.ExecuteSqlCommand(command);
                }
            }
        }

        public static string[] SeedDataBase()
        {
            var customCommands = new List<string>();
            customCommands.AddRange(ParseCommands(Path.Combine(string.Concat(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"App_Data\Install\DefaultData.sql")), false));
            customCommands.AddRange(ParseCommands(Path.Combine(string.Concat(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"App_Data\Install\StoredProcedures.sql")), false));

            return customCommands.ToArray();
        }

        #region Private methods
        private static string[] ParseCommands(string filePath, bool throwExceptionIfNonExists)
        {
            if (!File.Exists(filePath))
            {
                if (throwExceptionIfNonExists)
                    throw new ArgumentException(string.Format("Specified file doesn't exist - {0}", filePath));

                return new string[0];
            }


            var statements = new List<string>();
            using (var stream = File.OpenRead(filePath))
            using (var reader = new StreamReader(stream))
            {
                string statement;
                while ((statement = ReadNextStatementFromStream(reader)) != null)
                {
                    statements.Add(statement);
                }
            }

            return statements.ToArray();
        }

        private static string ReadNextStatementFromStream(StreamReader reader)
        {
            var sb = new StringBuilder();

            while (true)
            {
                var lineOfText = reader.ReadLine();
                if (lineOfText == null)
                {
                    if (sb.Length > 0)
                        return sb.ToString();

                    return null;
                }
                if (lineOfText.TrimEnd().ToUpper() == "GO")
                    break;

                sb.Append(lineOfText + Environment.NewLine);
            }

            return sb.ToString();
        }
        #endregion
    }
}
