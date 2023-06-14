import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public titlee: string = 'Meu projeto WEB 123';

  teste = 'teste 123';

  public deveRenderizarPalavraRecursos: boolean = false;

  public imprimir(): void {
    alert('Imprimir foi clicado');
  }

  public soma(valor1: number, valor2: number): number {
    return valor1 + valor2;
  }

  public metodoQualquer(parametro: any): any {

  }

}
