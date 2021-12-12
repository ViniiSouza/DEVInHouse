//
class Retangulo{
    constructor(altura, largura){
        this.altura = altura; this.largura = largura;
    }
    calcularArea(){
        var area = this.altura * this.largura;
        return area;
    }
}

var vetor = [new Retangulo(20, 15), new Retangulo(12,53), new Retangulo(22,52)]

vetor.forEach(element => {
    console.log(element.calcularArea())
});
