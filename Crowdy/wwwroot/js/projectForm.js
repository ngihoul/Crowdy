document.addEventListener('DOMContentLoaded', () => {
    const selectedCategories = [];
    const selectContainer = document.querySelector('.select-container');
    const selectGroup = document.querySelector('.select-group');
    const categorySelect = document.querySelector('.category-select');
    const addBtn = document.getElementById('category-btn');
    const hiddenInput = document.getElementById('hidden-categories');

    const createCategoryBox = (text) => {
        const div = document.createElement('div');
        div.classList.add("form-group");

        const input = document.createElement('input');
        input.classList.add('form-control');
        input.classList.add('mb-3');
        input.type = "text";
        input.value = text;
        input.disabled = true;

        div.appendChild(input);

        selectGroup.insertBefore(div, selectContainer);
    }

    const updateHiddenField = () => {
        hiddenInput.value = selectedCategories.join(',');
    }

    addBtn.addEventListener('click', (e) => {
        const selectedId = categorySelect.value;

        if (!selectedCategories.includes(selectedId) && selectedId != 0) {
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
                    <div class="threshold form-group row d-flex align-items-center">
                        <div class="col-sm-12 col-lg-2">
                            <label for="ProjectThresholds_${index}__Amount" class="form-label">Montant</label>
                            <input name="ProjectThresholds[${index}].Amount" id="ProjectThresholds_${index}__Amount" class="form-control" />
                            <span asp-validation-for="ProjectThresholds[${index}].Amount"></span>
                        </div>
                        <div class="col-sm-12 col-lg-10">
                            <label for="ProjectThresholds_${index}__Description" class="form-label">Description</label>
                            <input name="ProjectThresholds[${index}].Description" id="ProjectThresholds_${index}__Description" class="form-control" />
                            <span asp-validation-for="ProjectThresholds[${index}].Description"></span>
                        </div>
                    </div>
                    `;

        thresholdContainer.append(div);
        }

    thresholdBtn.addEventListener('click', addThreshold);
});