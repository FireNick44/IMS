import { ToDo } from './todo.js';

let todos = [];

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

document.addEventListener('DOMContentLoaded', (event) => {
  checkLocalstorage(); //localCheck -Y
  updateToDoListOnScreen();

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

document.addEventListener('change', (event) => {
  let count = 0;
  let allCheckboxes = document.querySelectorAll("#check");
  
  allCheckboxes.forEach((item) => {
    item.setAttribute("alt", count);
    count++;
  });

  //console.log(event.target.alt);
  //console.log(todos);

  if(todos[event.target.alt].erledigt) todos[event.target.alt].erledigt = false;
  else todos[event.target.alt].erledigt = true;

  //updateToDoListOnScreen();
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

  let itemTodosSet = (localStorage.getItem('todos') !== null);

  if(!itemTodosSet) {
    let firstToDos = [
      new ToDo('Zugticket kaufen', false),
      new ToDo('Wäsche waschen', true),
      new ToDo('Hausaufgaben machen', true),
    ];

    for (const tmpToDo of firstToDos) {
      const todo = new ToDo(tmpToDo.titel, tmpToDo.erledigt);
      
      todo.addEventListener('loeschen', (e) => {
        const index = todos.indexOf(e.target);
        todos.splice(index, 1);
        updateToDoListOnScreen();
      });
  
      todos.push(todo);
    }

  }

  let tmp = JSON.parse(localStorage.getItem('todos')) ? JSON.parse(localStorage.getItem('todos')) : []

  for (const tmpToDo of tmp) {
    const todo = new ToDo(tmpToDo.titel, tmpToDo.erledigt);
    
    todo.addEventListener('loeschen', (e) => {
      const index = todos.indexOf(e.target);
      todos.splice(index, 1);
      updateToDoListOnScreen();
    });

    todos.push(todo);
  }

  JSON.parse(localStorage.getItem('todos'))
}