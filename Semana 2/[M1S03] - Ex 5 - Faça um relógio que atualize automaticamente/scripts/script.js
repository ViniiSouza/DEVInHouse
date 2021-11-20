//

function atualizarHora(){
    setInterval(function atualizaHora(){
        var hora = new Date();
        hora = hora.getHours() + ":" + hora.getMinutes() + ":" + hora.getSeconds();
        document.querySelector("#resultado").textContent = hora;
    }, 10000)
}