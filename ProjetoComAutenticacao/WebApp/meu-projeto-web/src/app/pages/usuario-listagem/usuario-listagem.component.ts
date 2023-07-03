import { Component, OnInit } from '@angular/core';
import Pessoa from 'src/app/models/pessoa.model';
import { AlertService } from 'src/app/services/alert.service';
import { PessoaService } from 'src/app/services/pessoa.service';
import Usuario from "../../models/usuario.model";
import {UsuarioService} from "../../services/usuario.service";
import {AutenticacaoService} from "../../services/autenticacao.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-usuario-listagem',
  templateUrl: './usuario-listagem.component.html',
  styleUrls: ['./usuario-listagem.component.css']
})
export class UsuarioListagemComponent implements OnInit {

  public listaUsuarios: Usuario[] = [];

  constructor(
    public router: Router,
    public autenticacaoService: AutenticacaoService,
    public usuarioService: UsuarioService,
    public alertService: AlertService
  ) { }

  public ngOnInit(): void {
    document.title = 'Listagem de usuários';

    if(!this.autenticacaoService.tipoPerfilEhAdmin()) {
      this.router.navigate(['/principal']);
    }

    this.obterUsuariosDaApi();
  }

  public obterUsuariosDaApi(): void {
    // subscribe: oque o service tem que fazer quando tiver o retorno da api
    this.usuarioService.obterTodos().subscribe(resposta => {

      if(resposta != null) {
        this.listaUsuarios = resposta;
      } else {
        this.alertService.showToastrError('Erro na requisição com o servidor');
      }

    }, exception => {
      let mensagemErro = exception?.error instanceof String ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }

  public alterarStatus(usuario: Usuario): void {
    this.usuarioService.alterarStatus(usuario.id).subscribe(resposta => {

      if(resposta != null) {
        this.obterUsuariosDaApi();

        if(usuario.ativo) {
          this.alertService.showToastrSuccess('Usuário desativado com sucesso');
        } else {
          this.alertService.showToastrSuccess('Usuário ativado com sucesso');
        }

      } else {
        this.alertService.showToastrError('Erro na requisição com o servidor');
      }

    }, exception => {
      let mensagemErro = exception?.error instanceof String ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }

}
