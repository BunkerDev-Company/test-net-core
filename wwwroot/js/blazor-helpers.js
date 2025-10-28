window.ModalHelper = {
    show: function (id) {
        var modalEl = document.getElementById(id);
        var modal = bootstrap.Modal.getOrCreateInstance(modalEl);
        modal.show();
    },
    hide: function (id) {
        var modalEl = document.getElementById(id);
        var modal = bootstrap.Modal.getOrCreateInstance(modalEl);
        modal.hide();
    }
};
