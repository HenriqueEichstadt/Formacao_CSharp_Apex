import { Component, OnInit } from '@angular/core';
import Pessoa from 'src/app/models/pessoa.model';
import { PessoaService } from 'src/app/services/pessoa.service';

@Component({
  selector: 'app-pessoa-listagem',
  templateUrl: './pessoa-listagem.component.html',
  styleUrls: ['./pessoa-listagem.component.css']
})
export class PessoaListagemComponent implements OnInit {

  public listaPessoas: Pessoa[] = [];

  constructor(
    public pessoaService: PessoaService
  ) { }

  public ngOnInit(): void {
    document.title = 'Listagem de pessoas';

    this.obterPessoasDaApi();
  }

  public obterPessoasDaApi(): void {
    // subscribe: oque o service tem que fazer quando tiver o retorno da api
    this.pessoaService.obterTodos().subscribe(resposta => {

      if(resposta != null) {
        this.listaPessoas = resposta;
      } else {
        alert('Erro na requisição com o servidor');
      }

    });
  }

  public excluir(id: number): void {
    this.pessoaService.excluir(id).subscribe(resposta => {

      alert('A pessoa foi excluída com sucesso!');
      this.obterPessoasDaApi();
    });
  }

}
