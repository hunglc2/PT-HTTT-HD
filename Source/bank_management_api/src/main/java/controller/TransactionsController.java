package controller;

import java.util.ArrayList;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import model.Transactions;
import service.TransactionsService;

@Controller
@RestController
@RequestMapping("/transactions")
public class TransactionsController {
	@Autowired
	TransactionsService ps;

	@RequestMapping(method = RequestMethod.GET, value = "/all")
	public ArrayList<Transactions> getAll() {
		return ps.getAll();
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked" })
	@RequestMapping(value = "/{id}", method = RequestMethod.GET)
	public ResponseEntity getByID(@PathVariable("id") String id) {
		Transactions vObject = ps.getByID(Integer.parseInt(id));
		if (vObject == null) {
			return new ResponseEntity("No Transactions found for ID " + id, HttpStatus.NOT_FOUND);
		}
		
		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
	@SuppressWarnings({ "unchecked", "rawtypes", "null" })
	@RequestMapping(value = "/update", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<Transactions> updateOwner(@RequestBody Transactions vObject) {
		vObject = ps.update(vObject);
		if (vObject == null) {
			return new ResponseEntity("No Transactions found for ID " + vObject.getIdTransactions(), HttpStatus.NOT_FOUND);
		}

		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked" })
	@RequestMapping(value = "/insert", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<Transactions> insertOwner(@RequestBody Transactions vObject) {
		return new ResponseEntity(ps.insert(vObject), HttpStatus.OK);
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked", "null" })
	@RequestMapping(value = "/delete", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<Transactions> deletetOwner(@RequestBody Transactions vObject) {
		vObject = ps.delete(vObject);
		if (vObject == null) {
			return new ResponseEntity("No Owner found for ID " + vObject.getIdTransactions(), HttpStatus.NOT_FOUND);
		}
		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
}
