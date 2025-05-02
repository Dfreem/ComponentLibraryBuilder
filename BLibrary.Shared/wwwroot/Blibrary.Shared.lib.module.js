export function saveToSession(key, item) {
    window.sessionStorage.setItem(key, item);
}

export function getFromSession(key) {
    return window.sessionStorage.getItem(key);
}

export function removeFromSession(key) {
    let item = getFromSession(key);
    return window.sessionStorage.removeItem(key);
    return item;
}
export function saveToLocal(key, item) {
    window.localStorage.setItem(key, item);
}

export function getFromLocal(key) {
    return window.sessionStorage.getItem(key);
}

export function removeFromLocal(key) {
    let item = getFromSession(key);
    return window.sessionStorage.removeItem(key);
    return item;
}