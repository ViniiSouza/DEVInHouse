//

function mostrarHorario(){
    var hora = new Date();
    hora = hora.getHours() + ":" + hora.getMinutes()
    document.getElementById("horario").textContent = hora;
}