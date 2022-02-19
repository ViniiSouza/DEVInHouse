import Funcionario from "./Funcionario.js";

var funcionario1 = new Funcionario('João', 12345678910, 'Diretor', 5800);
var funcionario2 = new Funcionario('Clara', 10987654321, 'Sócia-dona', 15200);
var funcionario3 = new Funcionario('Wesley', 12121212121, 'Auxiliar', 2100);

var arrayFuncionarios = [funcionario1, funcionario2, funcionario3]

console.log('A soma dos salários é: R$ ' + Funcionario.calcularSalarios(arrayFuncionarios))
