import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'cpf'
})
export class CpfPipe implements PipeTransform {
  transform(value: any): string {
    // Remove caracteres não numéricos do valor
    const cleanedValue = value.replace(/\D/g, '');

    // Verifica se o valor está vazio ou possui um tamanho inválido
    if (!cleanedValue || cleanedValue.length !== 11) {
      return value;
    }

    // Formata o CPF no formato "###.###.###-##"
    return cleanedValue.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, '$1.$2.$3-$4');
  }
}
