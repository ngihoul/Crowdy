document.addEventListener('DOMContentLoaded', function () {
    const previewContainer = document.querySelector('.preview-container');
    const previewImg = document.querySelector('.preview-img');
    const imageInput = document.querySelector('.image');

    previewContainer.style.display = 'none';

    const displayImage = (e) => {
        const file = imageInput.files;

        if (file) {
            previewContainer.style.display = 'block';

            const fileReader = new FileReader();
            
            fileReader.onload = (e) => {
                previewImg.src = e.target.result;
            };

            fileReader.readAsDataURL(file[0]);
        }
    }

    imageInput.addEventListener('change', displayImage);
});