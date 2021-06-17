let btnShow = document.querySelector('button');   
let result = document.querySelector('h1');

btnShow.addEventListener('click', ()=> { 

    //let selected = document.querySelector('input[type="radio]:checked'); 
    //result.innerText=selected.value;



    var myDiv = document.getElementById("divId");
    myDiv.innerHTML = "Content To Show";

});


function changeDivContent(btn) {
    content.innerHTML = btn.value
  }


  function next(param_div_id) {
    document.getElementById('main_place').innerHTML = document.getElementById(param_div_id).innerHTML;
  }


  async function submit(){
    /* POST data to Backend and recieve calulated result. Save it */
    //next('confirmpage');
    await postInputJSON();
    //gatherinput();

}

