//

const dataAtual = new Date();
const anoAtual = new Date().getFullYear();

const inicioVerao = new Date(`${anoAtual-1}/12/22`);
const inicioOutono = new Date(`${anoAtual}/03/22`);
const inicioInverno = new Date(`${anoAtual}/06/22`);
const inicioPrimavera = new Date(`${anoAtual}/09/22`);
const inicioNovoVerao = new Date (`${anoAtual}/12/22`);

if(dataAtual >= inicioVerao && dataAtual < inicioOutono){
    console.log('Verão!')
    document.getElementById('estacao-imagem').src='../img/verao.jpg'
    document.getElementById('estacao-nome').textContent = 'Você está no verão!';
}
 

else if(dataAtual >= inicioOutono && dataAtual < inicioInverno){
    console.log('Outono!');
    document.getElementById('estacao-imagem').src='img/outono.jpg'
    document.getElementById('estacao-nome').textContent = 'Você está no outono!';
}


else if(dataAtual >=  inicioInverno && dataAtual < inicioPrimavera){
    console.log('Inverno!');
    document.getElementById('estacao-imagem').src='img/inverno.jpg'
    document.getElementById('estacao-nome').textContent = 'Você está no inverno!';
}

else if(dataAtual  >= inicioPrimavera && dataAtual < inicioNovoVerao) {
    console.log('Primavera!')
    document.getElementById('estacao-imagem').src='img/primavera.png'
    document.getElementById('estacao-nome').textContent = 'Você está na primavera!';
}
