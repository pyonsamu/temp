$(function(){
  Init();
  main();
})



function Init(){

}

function main(){

  window.addEventListener('click',function(){
    anime({
      targets: '#a',
      translateX: 250
    })
  })

}
