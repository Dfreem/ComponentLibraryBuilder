function showModal(elementRef) {
    if (elementRef === null || elementRef.__internalId === null || typeof elementRef == 'undefined') {
        return;
    }
    Array.from(document.getElementsByClassName('modal')).map((e) => {
        let modal = bootstrap.Modal.getOrCreateInstance(e);
        modal.hide();
    });
    const visibleModal = bootstrap.Modal.getOrCreateInstance(elementRef);
    visibleModal.show();
}

function hideModal(elementRef) {
    if (elementRef === null || elementRef.__internalId === null || typeof elementRef == 'undefined') {
        return;
    }
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
    if (modalRef === null || modalRef.__internalId === null || typeof modalRef == 'undefined') {
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
//function buildStyles(content, importPaths) {
//    let sass = new Sass();
//    let compiled = sass.compileString(content, {loadPaths: importPaths});
//    console.log(compiled);
//    console.log(content);
//    console.log(importPaths);
//}

