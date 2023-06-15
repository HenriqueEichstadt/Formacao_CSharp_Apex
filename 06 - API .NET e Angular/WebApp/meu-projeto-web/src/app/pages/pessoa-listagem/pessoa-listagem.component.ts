import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pessoa-listagem',
  templateUrl: './pessoa-listagem.component.html',
  styleUrls: ['./pessoa-listagem.component.css']
})
export class PessoaListagemComponent implements OnInit {

  constructor() { }

  public ngOnInit(): void {
    document.title = 'Listagem de pessoas';
  }

}
