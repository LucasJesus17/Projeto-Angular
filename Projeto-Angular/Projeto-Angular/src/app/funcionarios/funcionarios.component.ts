import { Funcionario } from '../models/Funcionario';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-funcionarios',
  templateUrl: './funcionarios.component.html',
  styleUrls: ['./funcionarios.component.css']
})
export class FuncionariosComponent implements OnInit {

  public funcionarioForm: FormGroup;
    
  public adicionarFuncionario: Funcionario;
  public funcionarioSelecionado: Funcionario;

  public funcionarios = [
    { id: 1, nome: 'vp', foto: 'SP', RG: 112224545, departamento:2},
    { id: 2, nome: 'cris', foto: 'SP', RG: 112224545, departamento:2},
    { id: 3, nome: 'carlos', foto: 'SP', RG: 112224545, departamento:2},
    { id: 4, nome: 'Cleber', foto: 'SP', RG: 112224545, departamento:2},
    { id: 5, nome: 'Jao', foto: 'SP', RG: 112224545, departamento:2},
  ];

  constructor(private fb: FormBuilder) {
    this.criarform();

   }

  ngOnInit(): void {
  }

  
  criarform(){
    this.funcionarioForm = this.fb.group({
      id:[''],
      nome:[''],
      RG:[''],
      foto:[''],
      departamento:['']
    });
  }

  enviar(){
     console.log(this.funcionarioForm.value);
  }

  addFuncionario(adicionar: Funcionario){ 
    this.funcionarioSelecionado = adicionar;


  }

  voltar(){
    this.funcionarioSelecionado = null;
    this.adicionarFuncionario = null;
  }

  funcionarioSelect(funcionario: Funcionario){
    this.funcionarioSelecionado = funcionario;
    this.funcionarioForm.patchValue(funcionario);

  }

  


}
