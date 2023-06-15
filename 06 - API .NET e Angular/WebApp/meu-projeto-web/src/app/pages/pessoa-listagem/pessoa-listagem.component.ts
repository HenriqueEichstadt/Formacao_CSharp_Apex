import { Component, OnInit } from '@angular/core';
import Pessoa from 'src/app/models/pessoa.model';

@Component({
  selector: 'app-pessoa-listagem',
  templateUrl: './pessoa-listagem.component.html',
  styleUrls: ['./pessoa-listagem.component.css']
})
export class PessoaListagemComponent implements OnInit {

  public mockPessoas: Pessoa[] = [
    new Pessoa({id: 1, nome: 'pessoa fake 1', cpf: '000.000.000-00', email: 'pessoa1@email.com', telefone: '(47) 99999-9999'}),
    new Pessoa({id: 2, nome: 'pessoa fake 2', cpf: '111.000.000-00', email: 'pessoa2@email.com', telefone: '(47) 98999-9999'}),
    new Pessoa({id: 3, nome: 'pessoa fake 3', cpf: '000.222.000-00', email: 'pessoa3@email.com', telefone: '(47) 97999-9999'}),
    new Pessoa({id: 4, nome: 'pessoa fake 4', cpf: '000.000.333-00', email: 'pessoa4@email.com', telefone: '(47) 96999-9999'}),
    new Pessoa({id: 5, nome: 'pessoa fake 5', cpf: '000.000.000-44', email: 'pessoa5@email.com', telefone: '(47) 95999-9999'}),
  ];

  constructor() { }

  public ngOnInit(): void {
    document.title = 'Listagem de pessoas';
  }

}
