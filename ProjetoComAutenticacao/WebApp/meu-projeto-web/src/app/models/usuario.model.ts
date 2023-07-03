
export default class Usuario {
  public id: number;
  public nomeUsuario: string;
  public email: string;
  public senha: string;
  public ativo: boolean;
  public tipo: string;

  constructor(obj?: any) {
    if (obj != null) {
      Object.assign(this, obj);
    }
  }

}
