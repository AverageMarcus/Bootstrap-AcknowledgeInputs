Bootstrap-AcknowledgeInputs
===========================

A small bootstrap plugin that provide form input controls that feedback to the user as to whether their input was valid.

Using Bootstrap-AcknowledgeInput.js
===================================

1. Make sure you include all the required files:

    &lt;html lang="en"&gt;
        &lt;head&gt;
            &lt;link rel="stylesheet" href="css/bootstrap.min.css"&gt;
            &lt;link rel="stylesheet" href="css/font-awesome.min.css"&gt;
        &lt;/head&gt;
        &lt;body&gt;
            &lt;!-- PAGE CONTENT --&gt;
            &lt;script type="text/javascript" src="js/jquery-1.9.1.min.js"&gt;&lt;/script&gt;
            &lt;script type="text/javascript" src="js/bootstrap.min.js" &gt;&lt;/script&gt;
            &lt;script type="text/javascript" src="js/bootstrap-acknowledgeinput.min.js" &gt;&lt;/script&gt;
        &lt;/body&gt;
    &lt;/html&gt; 

2. Define your form with new acknowledge inputs

    &lt;form&gt;
        &lt;label&gt;Username&lt;/label&gt;
        &lt;div class=&quot;input-append&quot; data-role=&quot;acknowledge-input&quot;&gt;
            &lt;input type=&quot;text&quot; required=&quot;required&quot; placeholder=&quot;Any Text Required&quot; data-type=&quot;text&quot; /&gt;
            &lt;div data-role=&quot;acknowledgement&quot;&gt;&lt;i&gt;&lt;/i&gt;&lt;/div&gt;
        &lt;/div&gt;
    &lt;/form&gt;

The key things to note here is the use of `data-role` and `data-type` (optional). <br/>
The `data-type` attribute tells the plugin what format the input text should be to warrant a success.<br/>
The current `data-type` options are `text` (default), `email` and `tel`.

3. Call the plugin on document ready

    &lt;script type=&quot;text/javascript&quot;&gt;
        $().ready(function() {
            $().acknowledgeinput();
        });
    &lt;/script&gt;
