document.addEventListener("DOMContentLoaded", function () {
    const links = document.querySelectorAll(".bar .link");
    const iframes = document.querySelectorAll(".frame iframe");
    const buttons = document.querySelectorAll(".button button");

    // ������������� �������� ������� �� ��������� (����)
    const defaultId = "agat";
    setActiveElement(defaultId);

    links.forEach(function (link) {
        link.addEventListener("click", function () {
            const id = this.id.trim(); // �������� ID ������ (��������, "agat")
            if (id) {
                setActiveElement(id);
            }
        });
    });

    function setActiveElement(id) {
        // ������� active � ���� iframe � ������
        document.querySelectorAll(".frame iframe, .button button").forEach(el => el.classList.remove("active"));

        // ������� ������ iframe � ������
        const targetIframe = document.querySelector(`.frame .${id}`);
        const targetButton = document.querySelector(`.button .${id}`);


        if (targetIframe) targetIframe.classList.add("active");
        if (targetButton) targetButton.classList.add("active");
    }
});
