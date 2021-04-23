var sec = 5;
$(".timer .number").text(sec);

function timer() {
  if (sec > 0) {
    sec--;
    $(".timer .number").text(sec);
  } else {
    $(".timer").fadeOut(500);
    $("#hola").show();
  }
}
setInterval("timer()", 1000);