import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Pessoa from '../models/pessoa.model';
import {Router} from "@angular/router";

@Injectable({
  providedIn: 'root'
})
export class AutenticacaoService {

  private chaveLocalStorageToken: string = 'token-login';
  private chaveLocalStorageDataExpiracaoToken: string = 'token-data-expiracao';
  private urlBase = 'http://localhost:5000/';

  constructor(
    public httpClient: HttpClient,
    public readonly router: Router
  ) { }

  public login(cmd: any) {
    return this.httpClient.post<any>(this.urlBase + 'autenticacao/login', cmd);
  }

  public estaLogado(): boolean {
    const tokenStorage = localStorage.getItem(this.chaveLocalStorageToken);

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

  public iniciarSessao(token: string, dataExpiracao: string): void {
    localStorage.setItem(this.chaveLocalStorageToken, token);
    localStorage.setItem(this.chaveLocalStorageDataExpiracaoToken, dataExpiracao);
  }

  private limparSessao(): void {
    localStorage.removeItem(this.chaveLocalStorageToken);
    localStorage.removeItem(this.chaveLocalStorageDataExpiracaoToken);
  }

}
