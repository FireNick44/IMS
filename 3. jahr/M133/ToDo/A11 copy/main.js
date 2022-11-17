import { ToDo } from './todo.js';

let todos = [];

// let todos = [
//   new ToDo('Zugticket kaufen', false),
//   new ToDo('Wäsche waschen', true),
//   new ToDo('Hausaufgaben machen', true),
// ];

function updateToDoListOnScreen() {
  const todoListElement = document.getElementById('todolist');

  // Liste leeren
  todoListElement.innerHTML = '';

  // sortieren -Y
  todos.sort((a, b) => a.titel.localeCompare(b.titel));

  // ToDo's einfügen
  for (const todo of todos) {
    const toDoListEntry = todo.element();
    todoListElement.appendChild(toDoListEntry);
  }

  // offene ToDo's
  const offeneToDos = todos.filter((offen) => !offen.erledigt);
  const elementAnzahl = document.getElementById('anzahl');
  elementAnzahl.textContent = `${offeneToDos.length} ToDo's offen`;

  // Storage speichern -Y
  localStorage.setItem('todos', JSON.stringify(todos, ["titel", "erledigt"]));
}

document.addEventListener("change", e => {
  console.log(e)
  if (e.input.checked == true) {
    console.log("checked");
  }
})

document.addEventListener('DOMContentLoaded', (event) => {
  checkLocalstorage(); //localCheck -Y
  updateToDoListOnScreen();


  const neuesCheckElement = document.querySelector('input[type=checkbox]');
  neuesCheckElement.addEventListener('change', function (event) {
      if (neuesCheckElement.checked) {
          // do something if checked
          console.log("checked");
      } else {
          // do something else otherwise
      }
  });

  const neuesToDoElement = document.getElementById('neuesToDo');
  neuesToDoElement.addEventListener('keydown', (event) => {
    if (event.code === 'Enter') {
      const todo = new ToDo(neuesToDoElement.value, false);
      todos.push(todo);

      neuesToDoElement.value = '';

      todo.addEventListener('loeschen', (e) => {
        const index = todos.indexOf(e.target);
        todos.splice(index, 1);
        updateToDoListOnScreen();
      });

      updateToDoListOnScreen();
    }
  });
});

//Lösche erledigt Button -Y
document.getElementById('aufraeumen').addEventListener('click', deleteToDoListElement); 

function deleteToDoListElement() {
  const offeneToDos = todos.filter((offen) => !offen.erledigt);
  todos = offeneToDos;

  updateToDoListOnScreen();
}

// aufruf von DOMLoaded -Y
function checkLocalstorage() {
  checkFirst()

  let tmp = JSON.parse(localStorage.getItem('todos')) ? JSON.parse(localStorage.getItem('todos')) : []
  for (const tmpToDo of tmp) {
    const todo = new ToDo(tmpToDo.titel, tmpToDo.erledigt);
    todos.push(todo);
  }

  JSON.parse(localStorage.getItem('todos'))
}

//Checkt ob es der erste aufruff ist -Y
function checkFirst() {
  const itemSet = (localStorage.getItem('first') !== null);

  if(!itemSet) {
    localStorage.setItem('first', true);

    todos = [
      new ToDo('Zugticket kaufen', false),
      new ToDo('Wäsche waschen', true),
      new ToDo('Hausaufgaben machen', true),
    ];
  }
}


//checkboxElement.addEventListener('click', checken(this));

function checken() {

}