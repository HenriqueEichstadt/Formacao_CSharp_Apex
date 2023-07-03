import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Pessoa from '../models/pessoa.model';
import {Router} from "@angular/router";

@Injectable({
  providedIn: 'root'
})
export class AutenticacaoService {

  private chaveLocalStorageToken: string = 'sessao-token';
  private chaveLocalStorageDataExpiracaoToken: string = 'sessao-token-data-expiracao';
  private chaveLocalStorageNomeUsuario: string = 'sessao-nome-usuario';
  private chaveLocalStorageEmail: string = 'sessao-email-usuario';
  private chaveLocalStorageTipoPerfil: string = 'sessao-tipo-perfil-usuario';
  private chaveLocalStorageIdUsuario: string = 'sessao-tipo-id-usuario';
  private urlBase = 'http://localhost:5000/';

  constructor(
    public httpClient: HttpClient,
    public readonly router: Router
  ) { }

  public login(cmd: any) {
    return this.httpClient.post<any>(this.urlBase + 'autenticacao/login', cmd);
  }

  public estaLogado(): boolean {
    const tokenStorage = this.obterTokenLogin();

    return tokenStorage != null && tokenStorage != "" && this.dataExpiracaoTokenMaiorQueAgora();
  }

  public dataExpiracaoTokenMaiorQueAgora(): boolean {
    const dataExpiracaoToken = localStorage.getItem(this.chaveLocalStorageDataExpiracaoToken);

    if(dataExpiracaoToken == null) {
      return false;
    }

    const dataExpiracaoTokenDate = new Date(dataExpiracaoToken).getTime();
    const dataAgora = new Date().getTime();
    return dataExpiracaoTokenDate > dataAgora;
  }

  public deslogarERedirecionarParaLogin(): void {
    this.limparSessao();
    this.router.navigate(["/login"]);
  }

  public obterTokenLogin(): string {
    return localStorage.getItem(this.chaveLocalStorageToken);
  }

  public obterNomeUsuario(): string {
    return localStorage.getItem(this.chaveLocalStorageNomeUsuario);
  }

  public tipoPerfilEhAdmin(): boolean {
    return localStorage.getItem(this.chaveLocalStorageTipoPerfil) == "administrador";
  }

  public obterIdUsuario(): number {
    return Number(localStorage.getItem(this.chaveLocalStorageIdUsuario));
  }

  public iniciarSessao(token: string, dataExpiracao: string, nomeUsuario: string, email: string, tipoPerfil: string, idUsuario: number): void {
    localStorage.setItem(this.chaveLocalStorageToken, token);
    localStorage.setItem(this.chaveLocalStorageDataExpiracaoToken, dataExpiracao);
    localStorage.setItem(this.chaveLocalStorageNomeUsuario, nomeUsuario);
    localStorage.setItem(this.chaveLocalStorageEmail, email);
    localStorage.setItem(this.chaveLocalStorageTipoPerfil, tipoPerfil);
    localStorage.setItem(this.chaveLocalStorageIdUsuario, idUsuario.toString());
  }

  private limparSessao(): void {
    localStorage.removeItem(this.chaveLocalStorageToken);
    localStorage.removeItem(this.chaveLocalStorageDataExpiracaoToken);
    localStorage.removeItem(this.chaveLocalStorageNomeUsuario);
    localStorage.removeItem(this.chaveLocalStorageEmail);
    localStorage.removeItem(this.chaveLocalStorageTipoPerfil);
    localStorage.removeItem(this.chaveLocalStorageIdUsuario);
  }

}
