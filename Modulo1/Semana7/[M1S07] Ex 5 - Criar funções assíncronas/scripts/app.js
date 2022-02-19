async function euNaoEspero() {
    aguarda5Segundos();
    console.log('Eu não espero')
}

async function aguarda5Segundos() {
    await new Promise(resolve => setTimeout(resolve, 3000)); // 3 sec
    console.log("Função diz: Terminei!")
}

euNaoEspero();

async function euEspero() {
    await aguarda5Segundos();
    console.log('Eu espero');
}

euEspero();