
    var form = document.getElementById("form");
    var minute = document.getElementById("minute");
    var second = document.getElementById("second");
    var issubmit = false;

    form.addEventListener('submit', function CheckSucess(event ) {
        var result = confirm("Bạn đã có muốn nộp bài không ?");
    if (result == false) {

        event.preventDefault();
        }

    });

    function submitForm() {
        if (issubmit == true) {
        form.submit();
        }

    }


    function SetTimeTest() {
        var minuteInt = parseInt(minute.innerText);
    var secondInt = parseInt(second.innerText);


    if (secondInt == 0) {
        minuteInt--;
    secondInt = 60;
        }

    secondInt--;
    minute.innerHTML = minuteInt.toString();
    if (secondInt < 10) {
        second.innerHTML = "0" + secondInt.toString();
        }
    else {
        second.innerHTML = secondInt.toString();
        }

    if (minute == 0 && second == 0) {
        issubmit = true;
    submitForm();
        }


    };

    setInterval(SetTimeTest, 1000);

