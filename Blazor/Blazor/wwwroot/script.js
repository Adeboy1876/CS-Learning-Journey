// Toggle Dark mode
function toggleDarkMode() {
    const body = document.querySelector("body");
    body.classList.toggle("dark-mode");
}
//show alert in image click
document.addEventListener("DOMContentLoaded", () => {
    const image = document.querySelector("img");
    image.addEventListener("click", () => {
        alert("Stop clicking me, I'm trying to sleep!");
    });
});

function addHobby() {
    //get Unordered list by id
    const hobbieslist = document.getElementById("hobbies-list");

    const newHobby = prompt("Enter a new hobby :");

    if (newHobby && newHobby.trim() !== "") {
        //create a new list item
        const li = document.createElement("li");
        li.textContent = newHobby;

        //optional styling

        //append the new list
        hobbieslist.appendChild(li);
    } else {
        alert("please enter a valid hobby")
    }
}