document.addEventListener('DOMContentLoaded', function () {
    const previewContainer = document.querySelector('.preview-avatar');
    const previewImg = document.querySelector('.preview-img');
    const avatarInput = document.querySelector('.avatar');

    previewContainer.style.display = 'none';

    const displayAvatar = (e) => {
        const file = avatarInput.files;

        if (file) {
            previewContainer.style.display = 'block';

            const fileReader = new FileReader();
            
            fileReader.onload = (e) => {
                previewImg.src = e.target.result;
            };

            fileReader.readAsDataURL(file[0]);
        }
    }

    avatarInput.addEventListener('change', displayAvatar);
});