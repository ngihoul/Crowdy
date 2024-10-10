document.addEventListener('DOMContentLoaded', () => {
    const selectedCategories = [];
    const categorySelect = document.querySelector('.category-select');
    const addBtn = document.getElementById('category-btn');
    const selectedCategoriesContainer = document.querySelector('.selected-categories-container');
    const hiddenInput = document.getElementById('hidden-categories');

    const createCategoryBox = (text) => {
        const span = document.createElement('span');
        span.classList.add('btn');
        span.classList.add('btn-outline-primary');
        span.classList.add('me-2');
        span.innerHTML = text;

        selectedCategoriesContainer.appendChild(span);
    }

    const updateHiddenField = () => {
        hiddenInput.value = selectedCategories.join(',');
    }

    selectedCategoriesContainer.innerHTML = '';

    addBtn.addEventListener('click', (e) => {
        const selectedId = categorySelect.value;

        if (!selectedCategories.includes(selectedId)) {
            const selectedText = categorySelect.selectedOptions[0].innerHTML;
            createCategoryBox(selectedText);

            selectedCategories.push(selectedId);

            updateHiddenField();
        }
    });

    const thresholdBtn = document.getElementById('threshold-btn');

    const addThreshold = () => {
        const thresholdContainer = document.querySelector('#thresholds');
        const index = thresholdContainer.children.length;
        const div = document.createElement('div');
        div.classList.add('threshold');
        div.innerHTML = `
                    <label for="ProjectThresholds_${index}__Amount" class="control-label">Montant</label>
                    <input name="ProjectThresholds[${index}].Amount" id="ProjectThresholds_${index}__Amount" class="form-control" />
                    <span asp-validation-for="ProjectThresholds[${index}].Amount"></span>

                    <label for="ProjectThresholds_${index}__Description" class="control-label">Description</label>
                    <input name="ProjectThresholds[${index}].Description" id="ProjectThresholds_${index}__Description" class="form-control" />
                    <span asp-validation-for="ProjectThresholds[${index}].Description"></span>`;

        thresholdContainer.append(div);
        }

    thresholdBtn.addEventListener('click', addThreshold);
});