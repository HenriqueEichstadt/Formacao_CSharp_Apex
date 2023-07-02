
export default class Pessoa {
  public id: number;
  public nome: string;
  public cpf: string;
  public email: string;
  public telefone: string;

  constructor(obj?: any) {
    if (obj != null) {
        Object.assign(this, obj);
    }
  }

}
