
export function onStarted(blazor) {
    console.log("blazor started");
    const modals = document.getElementsByClassName('.modal');
    Array.from(modals).map((m) => {
        const visibleModal = new bootstrap.Modal(m);
        visibleModal.addEventListener('shown.bs.modal', () => {
            const body = document.getElementsByTagName('body')[0];
            body.classList.remove('modal-open');
            body.style = "";
        });
    });
}