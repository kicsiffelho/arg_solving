var temp = 0;
let temp2 = 5;

/* window.onload = function loaded() {
  console.log("Page loaded");
  var content_div = document.getElementById("content");
  for (var i = 0; i < 5; i++) {
        var szoveg = document.createElement("p");
        szoveg.textContent = "text " + i;
        content_div.appendChild(szoveg);
  }
}*/

function kiiratas() {
  console.log("You clicked!" + temp);
  console.log("You clicked!", temp, "/", temp2);
  temp++;
  temp2++;
}

function kiiratas2() {
  for (var i = 0; i < 20; i++) {
    if (i == 5 || i == 10) {
      console.log("Alma");
    } else {
      console.log("i értéke:", i);
    }
  }
}

function szinvalto() {
  var bekezdes = document.getElementById("bekezdes");
  console.log(temp, bekezdes);
  switch (temp) {
    case 1:
        bekezdes.classList = "";
      bekezdes.style.color = "red";
      break;
    case 2:
      bekezdes.style.color = "green";
      break;
    case 3:
      bekezdes.style.color = "blue";
      break;
    case 4:
      bekezdes.style.color = "yellow";
      break;
    default:
      bekezdes.classList.add("bekezdes-szine");
      temp = 0;
      break;
  }
  temp++;
}

function sendMessage() {
    var name = document.getElementById("username").value;
    var email = document.getElementById("email").value;
    var pwd = document.getElementById("password").value;
    if (name == "" || email == "" || pwd == "") {
        alert("Fill out all fields");
        return;
    }
    if (document.getElementById("messageContainer")) {
        document.parentElement.removeChild("messageContainer");
    }
    var preview = document.getElementById("contact");
    var messageContainer = document.createElement("div");
    messageContainer.setAttribute("id", "messageContainer");

    var nameContainer = document.createElement("h3");
    var emailContainer = document.createElement("h6");
    var pwdContainer = document.createElement("p");


    nameContainer.textContent = "Dear " + name;
    pwdContainer.textContent = "Jelszava: " + pwd;
    emailContainer.textContent = "Emailje: " + email;

    messageContainer.appendChild(nameContainer);
    messageContainer.appendChild(emailContainer);
    messageContainer.appendChild(pwdContainer);

    preview.appendChild(messageContainer);
}