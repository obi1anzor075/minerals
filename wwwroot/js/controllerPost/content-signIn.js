const condition = document.getElementById('signIn');
const login = document.getElementById('login');
const reg = document.getElementById('register');

if (condition) {
  login.classList.add('hidden');
  reg.classList.remove('hidden');
}
  else
{
  login.classList.remove('hidden');
  reg.classList.add('hidden');
}