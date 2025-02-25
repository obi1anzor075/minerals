document.addEventListener("DOMContentLoaded", function () { //Скрипт загружается после загрузки всей html страницы
    const links = document.querySelectorAll(".bar a"); //Получение всей информации по ссылкам
    const iframes = document.querySelectorAll(".frame iframe"); //Получение всех iframe-ов
    const buttons = document.querySelectorAll(".button button"); //Получение всех кнопок

    // Функция активации элемента
    function setActiveElement(id) { //Выполнение функии с передачей id ссылки
        if (!id) return; //Если id не пустой вернуть его, чтобы использовать дальше

        // Убираем активный класс у всех iframe и кнопок
        document.querySelectorAll(".frame iframe, .button button").forEach(el => el.classList.remove("active"));

        // Ищем нужные элементы
        const targetIframe = document.querySelector(`.frame .${id}`);
        const targetButton = document.querySelector(`.button .${id}`);

        // Добавляем активный класс
        if (targetIframe) targetIframe.classList.add("active");
        if (targetButton) targetButton.classList.add("active");
    }

    // Устанавливаем активный элемент по умолчанию (Агат)
    setActiveElement("agat");

    // Обработчики кликов по ссылкам
    links.forEach(link => {
        link.addEventListener("click", function () { //Функция выполняется при клике
            const id = this.id.trim(); // Используем ID как класс
            setActiveElement(id); //Выполнение функции для установки активного элемента
        });
    });
});
