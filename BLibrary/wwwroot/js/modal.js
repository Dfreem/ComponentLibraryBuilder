function showModal(elementRef) {
    if (elementRef == null) {
        return;
        Array.from(document.getElementsByClassName('modal')).map((e) => {
            let modal = new bootstrap.Modal(e);
            modal.hide();
        });
    }
    const visibleModal = new bootstrap.Modal(elementRef);
    visibleModal.show();
}

function hideModal(elementRef) {
    console.log("hiding modal", elementRef);
    let modal = bootstrap.Modal.getOrCreateInstance(elementRef);
    if (!modal) {
        console.log('could not get an instance of modal, creating new.');
        modal = new bootstrap.Modal(elementRef);
        console.log(modal);
    }
    modal.hide();
    console.log("hiding modal", elementRef);
    document.getElementsByTagName('body')[0].style.paddingRight = 0;
}

function registerModalEvents(modalRef, dotnetRef, callOnShow, callOnHide) {
    console.log("modalRef while registering modal", modalRef);
    if (modalRef == null) {
        console.log("modal ref is null, showing dotnetRef");
        return;
    }
    modalRef.addEventListener('show.bs.modal', (e) => {
        dotnetRef.invokeMethodAsync(callOnShow);
    });
    modalRef.addEventListener('hide.bs.modal', (e) => {
        dotnetRef.invokeMethodAsync(callOnHide);
    });
}
