package com.josemeurer.demo.controller;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {

    @GetMapping("/private")
    public String endpointPrivate() {
        return "Hello World, private";
    }
}
