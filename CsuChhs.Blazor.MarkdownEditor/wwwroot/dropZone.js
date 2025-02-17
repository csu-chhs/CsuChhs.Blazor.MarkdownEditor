export function initializeDropZone(dropZoneElement, inputFile) {
    function onPaste(e) {
        inputFile.files = e.clipboardData.files;
        const event = new Event('change', { bubbles: true });
        inputFile.dispatchEvent(event);
    }
    
    dropZoneElement.addEventListener('paste', onPaste);
    
    return {
        dispose: () => {
            dropZoneElement.removeEventListener('paste', onPaste);
        }
    }
}