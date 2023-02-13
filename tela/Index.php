<!-- Views/Home/Index.cshtml -->
<html>
<body>
   <form action="" method="post">
      Name: <input type="text" name="txtName">
      <input type="submit" value="Submit">
   </form>
   @if (!string.IsNullOrEmpty(ViewBag.Name))
   {
      <h1>Hello, @ViewBag.Name!</h1>
   }
</body>
</html>