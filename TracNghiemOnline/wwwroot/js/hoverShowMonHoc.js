// hoverShowMonHoc.js

document.addEventListener("DOMContentLoaded", function () {
    const lopHocLinks = document.querySelectorAll(".lop-hoc-link");

    lopHocLinks.forEach(link => {
        link.addEventListener("mouseenter", function () {
            const monHocWindow = document.getElementById(`mon-hoc-${this.dataset.lopId}`);
            monHocWindow.classList.add("show");
        });

        link.addEventListener("mouseleave", function () {
            const monHocWindow = document.getElementById(`mon-hoc-${this.dataset.lopId}`);
            monHocWindow.classList.remove("show");
        });
    });
});
