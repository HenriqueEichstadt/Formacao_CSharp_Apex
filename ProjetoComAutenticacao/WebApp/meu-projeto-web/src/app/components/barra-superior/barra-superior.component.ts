import { Component, OnInit } from '@angular/core';
import {AutenticacaoService} from "../../services/autenticacao.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-barra-superior',
  templateUrl: './barra-superior.component.html',
  styleUrls: ['./barra-superior.component.css']
})
export class BarraSuperiorComponent implements OnInit {

  public tipoPerfilEhAdmin: boolean = null;

  constructor(
    public router: Router,
    public autenticacaoService: AutenticacaoService
  ) { }

  public ngOnInit(): void {
    this.tipoPerfilEhAdmin = this.autenticacaoService.tipoPerfilEhAdmin();
  }

  public logout(): void {
    this.autenticacaoService.deslogarERedirecionarParaLogin();
  }

  public editarPerfilUsuario(): void {
    const idUsuarioLogado = this.autenticacaoService.obterIdUsuario();
    this.router.navigate(['/usuario/cadastro/' + idUsuarioLogado]);
  }

}
