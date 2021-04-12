import { Component, OnInit } from '@angular/core';
import { Departamento } from '../models/departamento';

@Component({
  selector: 'app-departamentos',
  templateUrl: './departamentos.component.html',
  styleUrls: ['./departamentos.component.css']
})
export class DepartamentosComponent implements OnInit {

    public departamentoSelecionado: Departamento;
    public voltar = null;


    public departamentos = [
      { id: 1, nome: 'RH', sigla: 'SP'},
      { id: 2, nome: 'Logistica', sigla: 'RJ'},
      { id: 3, nome: 'Infraestrutura', sigla: 'MT'},
      { id: 4, nome: 'Documentação', sigla: 'BH'},
      { id: 5, nome: 'Marcos', sigla: 'AM'},
      
    ];
    
    departamentoSelect(departamento: Departamento){
      this.departamentoSelecionado = departamento;
  
    }

  constructor() { }

  ngOnInit(): void {
  }

}
