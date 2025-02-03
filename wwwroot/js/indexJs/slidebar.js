const slides = document.querySelectorAll('.slide');
const prevButton = document.getElementById('prev');
const nextButton = document.getElementById('next');
let currentIndex = 0;
let timer;

function showSlide(index) {
  slides.forEach((slide, i) => {
    slide.classList.remove('active');
    if (i === index) {
      slide.classList.add('active');
    }
  });
}

function moveSlide(step) {
  currentIndex = (currentIndex + step + slides.length) % slides.length;
  showSlide(currentIndex);
  resetTimer();
}

function autoSlide() {
  currentIndex = (currentIndex + 1) % slides.length;
  showSlide(currentIndex);
}

function resetTimer() {
  clearInterval(timer);
  timer = setInterval(autoSlide, 4000);
}

prevButton.addEventListener('click', () => moveSlide(-1));
nextButton.addEventListener('click', () => moveSlide(1));

showSlide(currentIndex);
resetTimer();