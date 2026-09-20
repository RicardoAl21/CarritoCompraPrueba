import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment.development';
import { StoreApi } from '../../../../environments/store.api';   

@Injectable({
    providedIn: 'root'
})
export class AuthService 
{

    private readonly token = 'access_token';

    constructor(private http: HttpClient) 
    {    }

    login(email: string, password: string)
    {
        const url = environment.apiUrl + StoreApi.api.AUTENTICAR + StoreApi.Auth.LOGIN;
        return this.http.post<any>(url, { email, password });
    }

    logout() : void 
    {
      localStorage.removeItem(this.token);
    }

    getToken() : string | null
    {
        return localStorage.getItem(this.token);
    }

    isAuthenticated(): boolean {

    const token = this.getToken();

    if (!token) {
      return false;
    }

    return !this.isTokenExpired(token);
    }

    private isTokenExpired(token: string): boolean {

    try {

      const payload = JSON.parse(
        atob(token.split('.')[1])
      );

      const expiration = payload.exp;

      if (!expiration) {
        return true;
      }

      const currentTime = Math.floor(
        Date.now() / 1000
      );

      return expiration < currentTime;

    } 
    catch 
    {
      return true;
    }
    }
}
