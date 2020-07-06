function ShowNotificationModal(title = '', message = '', type = 'default') {
    $('#message-modal').addClass(type);
    $('#message-modal_title').text(title);
    $('#message-modal_message').text(message);
    $('#message-modal').modal();
}

function ShowConfirmationDelete(id, empleado) {
    $('#confirmation-modal_id').text(id);
    $('#confirmation-modal_employee').text(empleado);
    $('#confirmation-modal').modal();
}