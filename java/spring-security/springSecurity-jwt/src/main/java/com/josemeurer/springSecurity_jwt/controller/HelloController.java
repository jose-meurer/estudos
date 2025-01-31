package com.josemeurer.springSecurity_jwt.controller;

import com.josemeurer.springSecurity_jwt.dto.HelloDTO;
import org.springframework.http.ResponseEntity;
import org.springframework.security.access.prepost.PostAuthorize;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.time.Instant;

@RestController
public class HelloController {

    @GetMapping("/public")
    public ResponseEntity<HelloDTO> helloPublic() {
        return ResponseEntity.ok().body(new HelloDTO("Esse endpoint é visivel ao publico", Instant.now()));
    }


    @GetMapping("/private")
    public ResponseEntity<HelloDTO> helloPrivate() {
        return ResponseEntity.ok().body(
                new HelloDTO("Esse endpoint é visivel apenas para quem esta autenticado", Instant.now()));
    }

    @GetMapping("/private/user")
    @PreAuthorize("hasRole('USER')")
    public ResponseEntity<HelloDTO> helloUser() {
        return ResponseEntity.ok().body(
                new HelloDTO("Esse endpoint é visivel apenas para quem tem role de USER", Instant.now()));
    }

    @GetMapping("/private/admin")
    @PreAuthorize("hasRole('ADMIN')")
    public ResponseEntity<HelloDTO> helloAdmin() {
        return ResponseEntity.ok().body(
                new HelloDTO("Esse endpoint é visivel apenas para quem tem role de ADMIN", Instant.now()));
    }
}
