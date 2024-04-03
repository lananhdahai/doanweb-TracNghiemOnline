
    var form = document.getElementById("form");
    var Hourse   = document.getElementById("Hourse");
var second = document.getElementById("second");
var minutes = document.getElementById("minutes");
var issubmit = false;
var NumberOfTest = document.getElementById("NumberOfTest").innerHTML;
var isChecked = true;

form.addEventListener('submit', function CheckSucess(event) {
    SetData();
        var result = confirm("Bạn đã có muốn nộp bài không ?");
        if (result == false) { event.preventDefault(); }
        let IsRadioCheckedss = IsRadioCheckeds();
        if (IsRadioCheckedss == false) {
                alert("Bạn cần hoàn thành tất cả các câu!");
            event.preventDefault();
        }

 

    });

function submitForm() {
    SetData();
        if (issubmit == true) {
          
                form.submit();
        }

    }


    function SetTimeTest() {
        var HourseInt = parseInt(Hourse.innerText);
        var secondInt = parseInt(second.innerText);
        var minuteInt = parseInt(minutes.innerHTML);


        if (HourseInt == 0 && secondInt == 0 && minuteInt==0) {
            issubmit = true;
          
            submitForm();
        }
       

        if (minuteInt <= 0) {
            secondInt--;
            if (secondInt == 0) {
                HourseInt--;
                secondInt = 59;
            }
            minuteInt = 60;
           
        }

        minuteInt--;
    
        if (minuteInt < 10) {
            minutes.innerHTML = "0" + minuteInt.toString();
        }
        else {
            minutes.innerHTML = minuteInt.toString();
        }

        if (HourseInt < 10) {
            Hourse.innerHTML = "0" + HourseInt.toString();
        }
        else {
            Hourse.innerHTML = HourseInt.toString();
        }

        if (secondInt < 10) {
            second.innerHTML = "0" + secondInt.toString();
        }
        else {
            second.innerHTML = secondInt.toString();
        }

       


    };

setInterval(SetTimeTest, 1000);


function IsRadioCheckeds() {
    NumberOfTest = parseInt(NumberOfTest);
    for (let i = 0; i < NumberOfTest; i++) {
        let count = 0;
        var checkedRadio = document.getElementsByName(i);
        for (let j = 0; j < checkedRadio.length; j++) {
            if (checkedRadio[j].checked === true) {
                count++;
            }
             
        }
        if (count != 1) {
           
            return false;
        }
    }
    return true;
}


function SetData() {
    NumberOfTest = parseInt(NumberOfTest);
    let Data = "";
    let cau = "Cau";
    for (let i = 0; i < NumberOfTest; i++) {
        let Id = cau + i.toString();
        var itemid = document.getElementById(Id).innerHTML;
        var checkedRadio = document.getElementsByName(i);
       
        for (let j = 0; j < checkedRadio.length; j++) {
            if (checkedRadio[j].checked === true) {
                Data += j +","+ itemid +";";
            }

        }

    }

    document.getElementById('Data').value = Data.toString();
}



