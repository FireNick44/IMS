let data = [
  { id: 1, title: "Top Gun: Maverik", year: "2022" },
  {
    id: 2,
    title: "Top Gun -  Sie fürchten weder Tod noch Teufel",
    year: "1986",
  },
  { id: 3, title: "Spider-Man: No Way Home", year: "2021" },
  { id: 4, title: "Avengers: Endgame", year: "2019" },
  { id: 5, title: "Avengers: Infinity War", year: "2018" },
];

var idCount = 6; 
//ID wird nur hochgezählt, somit wird getNextId nicht gebraucht
//getNextId() geht nicht wenn man ein Objekt löscht
//Danke Demian -Yannic ;)

function getNextId() {
  return Number.isFinite(parseInt((Math.max(...data.map((movie) => movie.id))), 10))
  ? Math.max(...data.map((movie) => movie.id)) + 1
  : 1;
}

function insert(movie) {
  movie.id = idCount;
  data.push(movie);
  idCount++;
}

function update(movie) {
  data[movie.id-1] = movie;
}

export function getAll() {
  return Promise.resolve(data);
}

export function get(id) {
  return(data[id]);
}

export function remove(id) {
  delete data[--id];
  console.log(data)
}

export function save(movie) {
  if (movie.id === '') {
      insert(movie);
  }else {
      update(movie);
  }
  return Promise.resolve();
}