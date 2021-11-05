function Ticket(release, time, age) {
  this.release = release;
  this.time = time;
  this.age = age;
  this.cost = 0;
}

Ticket.prototype.price = function(release, time, age) {
  if (this.release === "1") {
    this.cost += 10;
  } else if (this.release === "2") {
    this.cost +=10;
  } if (this.time === "3") {
    this.cost +=2;
  } else if (this.time === "4") {
    this.cost+=5;
  } if (this.age === "5") {
    this.cost-=5;
  } else if (this.age === "6") {
    this.cost+=3;
  }
};

$(document).ready(function() {
  $("form#price").submit(function(event) {
    event.preventDefault();
    const release = ($("#release").val());
    console.log(release)
    const time = ($("#time").val());
    const age = ($("#age").val());
    let newTicket = new Ticket(release, time, age);
    newTicket.price(release, time, age);
    $(".output").text(newTicket.cost);
    $("#result").show()

  });
});














//1. Create Ticket constructor 
//2. Create new instance inside constructor
//3. Create Release function
//4. Create time function
//5. Create age function
//6. Create price function