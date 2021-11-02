function Ticket (nameOfMovie, time, age) {
  this.nameOfMovie = nameOfMovie;
  this.time = time;
  this.age = age;
}

Ticket.prototype.price = function() {
  let ticketPrice = 0;

  this.price = ticketPrice;
};

function Marquee () {
  this.movies = {};
}

function Movie (nameOfMovie, daysOld) {
  this.nameOfMovie = nameOfMovie;
  this.daysOld = daysOld;
}

