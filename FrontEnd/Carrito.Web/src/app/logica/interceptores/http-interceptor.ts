import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { catchError, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { AuthService } from '../servicios/auth-service';

export const httpInterceptor: HttpInterceptorFn = 
    (req, next) => {
      const servicio = inject(AuthService);
      const router = inject(Router);
      const token = servicio.getToken();

      let authReq = req;

      if(token)
      {
        authReq = req.clone({
          setHeaders: {
            Authorization: `Bearer ${token}`
          }
        });
      }

  return next(authReq).pipe(

    catchError((error: HttpErrorResponse) => 
      {
        if (error.status === 401) 
        {
          router.navigate(['/login']);
        }
        return throwError(() => error);
      })
  );
  
};
