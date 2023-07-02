import { Component, OnInit } from '@angular/core';
import Pessoa from 'src/app/models/pessoa.model';
import { AlertService } from 'src/app/services/alert.service';
import { PessoaService } from 'src/app/services/pessoa.service';

@Component({
  selector: 'app-pessoa-listagem',
  templateUrl: './pessoa-listagem.component.html',
  styleUrls: ['./pessoa-listagem.component.css']
})
export class PessoaListagemComponent implements OnInit {

  public listaPessoas: Pessoa[] = [];

  constructor(
    public pessoaService: PessoaService,
    public alertService: AlertService
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
        this.alertService.showToastrError('Erro na requisição com o servidor');
      }

    });
  }

  public confirmarEExcluir(id: number): void {
    this.alertService.alertConfirm({
      title: 'Atenção',
      text: 'Você deseja realmente excluir o registro?',
      confirmButtonText: 'Sim',
      confirmButtonColor: "green",
      showCancelButton: true,
      cancelButtonText: 'Não',
      cancelButtonColor: "red",
      fn: () =>{
        this.chamarApiParaExcluir(id);
      },
      fnCancel: () => {

      }
    });
  }

  private chamarApiParaExcluir(id: number): void {
    this.pessoaService.excluir(id).subscribe(resposta => {

      this.alertService.showToastrSuccess('A pessoa foi excluída com sucesso');
      this.obterPessoasDaApi();
    });
  }

}
