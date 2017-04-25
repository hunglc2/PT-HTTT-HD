package org.hoannguyen.bm.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class MainController {
	
	@RequestMapping("/")
    public String index(Model model) {
        model.addAttribute("greeting", "Hello Spring MVC");
        return "index";
    }
	
	@RequestMapping("/customer")
    public String customer(Model model) {
        //model.addAttribute("greeting", "Hello Spring MVC");
        //model.addAttribute("title", "Spring MVC");
        return "customer";
    }
}
