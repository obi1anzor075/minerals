const agatId = document.getElementById('agat');
const ametistId = document.getElementById('ametist');
const lasurId = document.getElementById('lasur');
//1

agatActive();

agatId.addEventListener('click', agatActive);
ametistId.addEventListener('click', ametistActive);
lasurId.addEventListener('click', lasurActive);
//2

function agatActive() {
  const ametistElements = document.querySelectorAll('.ametist');
  const agatElements = document.querySelectorAll('.agat');
  const lasurElements = document.querySelectorAll('.lasur')
  //3

  agatElements.forEach(element => element.classList.add('active'));
  ametistElements.forEach(element => element.classList.remove('active'));
  lasurElements.forEach(element => element.classList.remove('active'));
  //4
}

function ametistActive() {
  const ametistElements = document.querySelectorAll('.ametist');
  const agatElements = document.querySelectorAll('.agat');
  const lasurElements = document.querySelectorAll('.lasur')
  //3


  agatElements.forEach(element => element.classList.remove('active'));
  ametistElements.forEach(element => element.classList.add('active'));
  lasurElements.forEach(element => element.classList.remove('active'));
  //4
}

function lasurActive() {
  const ametistElements = document.querySelectorAll('.ametist');
  const agatElements = document.querySelectorAll('.agat');
  const lasurElements = document.querySelectorAll('.lasur')
  //3


  agatElements.forEach(element => element.classList.remove('active'));
  ametistElements.forEach(element => element.classList.remove('active'));
  lasurElements.forEach(element => element.classList.add('active'));
  //4
}

//5(2)