const article = document.querySelectorAll(".article-body");
const pageDots = document.querySelector(".page-dots");

let currentIndex = 0;

function showArticle(index) {
    article.forEach((card, i) => {
        if (i >= index && i < index + 3) {
            card.style.display = "block";
        } else {
            card.style.display = "none";
        }
    });
}

function createPageDots() {
    const numPages = Math.ceil(article.length / 3);
    for (let i = 0; i < numPages; i++) {
        const dot = document.createElement("span");
        dot.classList.add("page-dot");
        dot.addEventListener("click", () => {
            currentIndex = i * 3;
            showArticle(currentIndex);
            updatePageDots();
        });
        pageDots.appendChild(dot);
    }
}

function updatePageDots() {
    const dots = document.querySelectorAll(".page-dot");
    dots.forEach((dot, i) => {
        if (i * 3 === currentIndex) {
            dot.classList.add("active");
        } else {
            dot.classList.remove("active");
        }
    });
}

createPageDots();
showArticle(currentIndex);
updatePageDots();