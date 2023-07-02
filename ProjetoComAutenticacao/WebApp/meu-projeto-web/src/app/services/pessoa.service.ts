import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Pessoa from '../models/pessoa.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PessoaService {

  private urlBase = 'http://localhost:5000/';

  constructor(
    public httpClient: HttpClient
  ) { }

  public adicionar(pessoa: Pessoa) {
    return this.httpClient.post<Pessoa>(this.urlBase + 'pessoa/adicionar', pessoa);
  }

  public atualizar(pessoa: Pessoa) {
    return this.httpClient.put<Pessoa>(this.urlBase + 'pessoa/atualizar', pessoa);
  }

  public excluir(id: number) {
    return this.httpClient.delete<any>(this.urlBase + 'pessoa/excluir/' + id);
  }

  public obterPorId(id: number) {
    return this.httpClient.get<Pessoa>(this.urlBase + 'pessoa/obterPorId/' + id);
  }

  public obterTodos() {
    return this.httpClient.get<Pessoa[]>(this.urlBase + 'pessoa/obterTodos');
  }

}
