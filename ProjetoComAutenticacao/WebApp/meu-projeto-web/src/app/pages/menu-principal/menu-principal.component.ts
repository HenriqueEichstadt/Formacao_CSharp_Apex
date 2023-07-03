import { Component, OnDestroy, OnInit } from '@angular/core';
import {AutenticacaoService} from "../../services/autenticacao.service";

@Component({
  selector: 'app-menu-principal',
  templateUrl: './menu-principal.component.html',
  styleUrls: ['./menu-principal.component.css']
})
export class MenuPrincipalComponent implements OnInit, OnDestroy {

  public nomeUsuario: string = null;
  public tipoPerfilEhAdmin: boolean = null;

  constructor(
    public autenticacaoService: AutenticacaoService
  ) { }

  public ngOnInit(): void {
    document.title = 'Menu principal';

    this.nomeUsuario = this.autenticacaoService.obterNomeUsuario();
    this.tipoPerfilEhAdmin = this.autenticacaoService.tipoPerfilEhAdmin();
  }

  public ngOnDestroy(): void {

  }

  public imprimir(): void {
    alert('Imprimir foi clicado');
  }

  public soma(valor1: number, valor2: number): number {
    return valor1 + valor2;
  }

  public metodoQualquer(parametro: any): any {

  }

}
